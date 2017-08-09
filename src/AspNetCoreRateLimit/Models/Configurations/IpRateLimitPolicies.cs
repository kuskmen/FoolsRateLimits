namespace FoolsRateLimits.Models.Configurations
{
	using System.Collections.Generic;
	
	/// <summary>
	///  Model containing all ip rate limit policies in configuration file.
	/// </summary>
	public class IpRateLimitPolicies
    {
		/// <summary>
		///  All the rules per ip in configuration file.
		/// </summary>
        public List<IpRateLimitPolicy> IpRules { get; set; }
    }
}
