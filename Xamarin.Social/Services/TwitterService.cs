using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Xamarin.Social.Services
{
	public abstract class TwitterService : Service
	{
		public TwitterService ()
			: base ("Twitter", "Twitter")
		{
			CreateAccountLink = new Uri ("https://twitter.com/signup");
			ShareTitle = "Tweet";
			CanShareText = true;
			CanShareLinks = true;
			CanShareImages = true;
		}

		protected override Authenticator GetAuthenticator ()
		{
			throw new NotImplementedException ();
		}

		public override Request CreateRequest (string method, Uri url, IDictionary<string, string> paramters, Account account)
		{
			throw new System.NotImplementedException ();
		}
	}
}

