using System.Collections.Generic;
using System.Text.Json.Serialization;

using Dysnomia.Common.WebAPIWrapper.Helpers;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class SDRConfig {
		public int revision { get; set; }
		public IEnumerable<string> certs { get; set; }
		public IDictionary<string, int> p2p_share_ip { get; set; }
		public IDictionary<string, SDRConfigPop> pops { get; set; }
		public string relay_public_key { get; set; }
		public IEnumerable<string> revoked_keys { get; set; }
		[JsonConverter(typeof(NumberToBooleanConverter))]
		public bool success { get; set; }
	}

	public class SDRConfigPop {
		public string desc { get; set; }
		public IEnumerable<double> geo { get; set; }
		public IEnumerable<SDRConfigPopRelay> relays { get; set; }
	}

	public class SDRConfigPopRelay {
		public string ipv4 { get; set; }
		public IEnumerable<short> port_range { get; set; }
	}
}
