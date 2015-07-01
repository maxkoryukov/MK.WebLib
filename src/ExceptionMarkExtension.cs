﻿using System;

namespace MK
{
	/// <summary>
	/// Метим исключения, как наши, родные, хорошие, обрабатываемые
	/// </summary>
	public static class ExceptionMarkExtension
	{
		public const string Mark = "vlb-exc-flag";
		public static Exception SetMark(this Exception e)
		{
			if (null != e)
				if (!e.Data.Contains(Mark))
					e.Data.Add(Mark, true);

			return e;
		}
		public static bool GetMark(this Exception e)
		{
			if (null == e)
				return false;

			if (!e.Data.Contains(Mark))
				return false;
		
			return (bool)e.Data[Mark];
		}
	}
}