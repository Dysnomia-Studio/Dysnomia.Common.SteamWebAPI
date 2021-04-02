using System;

namespace Dysnomia.Common.SteamWebAPI.Exceptions {
	public class ForbiddenException : Exception {
		public ForbiddenException(string message) : base(message) { }
	}
}
