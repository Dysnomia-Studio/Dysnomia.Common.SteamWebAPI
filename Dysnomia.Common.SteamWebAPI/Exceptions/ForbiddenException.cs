using System;

namespace Dysnomia.Common.SteamWebAPI.Exceptions {
	public class ForbiddenException : Exception {
		protected ForbiddenException() : base() { }
		public ForbiddenException(string message) : base(message) { }
		public ForbiddenException(string message, Exception innerException) : base(message, innerException) { }
	}
}
