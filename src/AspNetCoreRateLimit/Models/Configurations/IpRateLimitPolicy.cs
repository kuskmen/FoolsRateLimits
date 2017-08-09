namespace FoolsRateLimits.Models.Configurations
{
	using System.Collections.Generic;
	
	/// <summary>
	///  Ip rate limit policy model, used to override general ip rate limit rules.
	/// </summary>
	public class IpRateLimitPolicy
    {
		/// <summary>
		///  Ip that this policy will apply to.
		/// </summary>
        public string Ip { get; set; }
		
		/// <summary>
		///  New rules that will apply for <see cref="Ip"/>.
		/// </summary>
        public List<RateLimitRule> Rules { get; set; }
    }
}
