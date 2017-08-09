namespace FoolsRateLimits.Models.Configurations
{
	using System.Collections.Generic;
	
	/// <summary>
	/// Model, holding all <see cref="ClientRateLimitPolicy"/>s in the configuration file.
	/// </summary>
	public class ClientRateLimitPolicies
    {
		/// <summary>
		///  List of client rules in the configuration file.
		/// </summary>
        public List<ClientRateLimitPolicy> ClientRules { get; set; }
    }
}
