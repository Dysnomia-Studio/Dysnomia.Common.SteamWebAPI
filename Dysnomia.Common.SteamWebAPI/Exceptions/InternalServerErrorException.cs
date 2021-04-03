using System;

namespace Dysnomia.Common.SteamWebAPI.Exceptions {
	public class InternalServerErrorException : Exception {
		public InternalServerErrorException(string message) : base(message) { }
	}
}
