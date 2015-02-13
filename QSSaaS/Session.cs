﻿using System;
using System.ServiceModel.Web;
using System.ServiceModel;
using NLog;
using System.Threading;

namespace QSSaaS
{
	public class Session
	{
		//Адрес сервера
		public static String ServiceAddress = "http://saas.qsolution.ru:2048/";
		public static String SaaSService = ServiceAddress + "SaaS";
		public static String UpdaterService = ServiceAddress + "Updater";
		//Параметры сессии
		public static String SessionId = String.Empty;
		public static bool IsSaasConnection = false;
		public static string Account = String.Empty;
		public static string BaseName = String.Empty;

		private static TimerCallback callback;
		private static Timer timer;
		private static Logger logger = LogManager.GetCurrentClassLogger ();

		public static ISaaSService GetSaaSService ()
		{
			try {
				Uri address = new Uri (SaaSService);
				var factory = new WebChannelFactory<ISaaSService> (new WebHttpBinding { AllowCookies = true }, address);
				return factory.CreateChannel ();
			} catch (Exception ex) {
				logger.ErrorException ("Ошибка создания подключения к SaaS сервису", ex);
				return null;
			}
		}

		private static void Refresh (Object StateInfo)
		{
			if (SessionId == String.Empty) {
				logger.Error ("Не задан ID сессии!");
				return;
			}
			try {
				ISaaSService svc = GetSaaSService ();
				if (!svc.refreshSession (SessionId))
					logger.Warn ("Не удалось продлить сессию " + SessionId + ".");
			} catch (Exception ex) {
				logger.ErrorException ("Ошибка при продлении сессии " + SessionId + ".", ex);
			}
		}

		public static void StartSessionRefresh ()
		{
			if (!IsSaasConnection)
				return;
			callback = new TimerCallback (Refresh);
			timer = new Timer (callback, null, 0, 300000);
		}

		public static void StopSessionRefresh ()
		{
			if (!IsSaasConnection)
				return;
			timer.Dispose ();
		}
	}
}
