namespace FoolsRateLimits.Models.Configurations
{
	using System.Collections.Generic;
	
	/// <summary>
	///  Client rate limit policy that will override general rules for client rate limiting.
	/// </summary>
	public class ClientRateLimitPolicy
    {
		/// <summary>
		///  Client id to override general rate limit rules for.
		/// </summary>
        public string ClientId { get; set; }
		/// <summary>
		///  List of rate limit rules to apply.
		/// </summary>
        public List<RateLimitRule> Rules { get; set; }
    }
}
