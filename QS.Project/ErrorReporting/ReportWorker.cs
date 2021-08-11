﻿using System;
using System.ServiceModel;
using NLog;

namespace QS.ErrorReporting
{
	public static class ReportWorker
	{
		public static String ServiceAddress = "http://saas.qsolution.ru:2048/ErrorReporting";

		static Logger logger = LogManager.GetCurrentClassLogger ();

		public static IErrorReportingService GetReportService ()
		{
			try {
				var factory = new ChannelFactory<IErrorReportingService> (new BasicHttpBinding (), ServiceAddress);
				return factory.CreateChannel ();
			} catch (Exception ex) {
				logger.Error (ex, "Ошибка создания подключения к сервису BugReporting.");
				return null;
			}
		}
	}
}

