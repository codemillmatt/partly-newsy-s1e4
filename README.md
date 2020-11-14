Welcome back to Partly Cloudy! The show where you learn how to build a cloud-connected Xamarin mobile application. We start from nothing and don't quit until it's ready for the App Store!

# Episode Recap

In this episode we add something that every app needs - but it's sometimes tricky to do ... add authentication!!

[Check out the show](https://channel9.msdn.com/Shows/Partly-Cloudy/Who-Are-You-App-Center-Auth?WT.mc_id=mobile-0000-masoucou) - then come on back to get a recap on what happened and some extra pointers on some stuff I had to gloss over.  (Or if you need to catch up - [all the episodes are here](https://channel9.msdn.com/Shows/Partly-Cloudy?WT.mc_id=mobile-0000-masoucou)!)

## Authentication

So we're gonna allow users to log in to our application - this way they can customize the application to obtain exactly the news that they want. And this way you don't have to worry about seeing the articles I want to see - and I don't have to worry about seeing the articles that you want to see!

So how do we do this?

### App Center

That's right, we use [App Center](https://docs.microsoft.com/appcenter/auth/?WT.mc_id=mobile-0000-masoucou) to allow users to create accounts and sign-in to the application! Actually, App Center provides a nice wrapper around [Azure AD B2C](https://docs.microsoft.com/azure/active-directory-b2c/?WT.mc_id=mobile-0000-masoucou) and [MSAL](https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki). It's B2C that holds the user store and all that goodness. And MSAL is the SDK that interacts with B2C and handles all lowdown OAuth stuff.

But App Center wraps them in a super duper easy to use SDK.

### Authenticating Users

I won't reiterate how to set everything up - rather I'll point you to the [documentation](https://docs.microsoft.com/appcenter/sdk/auth/xamarin?WT.mc_id=mobile-0000-masoucou). It's thorough. It's correct. It's kept up to date.

Once you have everything setup for Azure AD B2C, connected it to App Center, [added the NuGet](https://www.nuget.org/packages/Microsoft.AppCenter.Auth/), and then initialized in your `info.plist` and `AndroidManifest.xml` you're ready to do some coding.

To sign users in:

`Auth.SignInAsync()`

Done and done! That function will also take care of letting users create accounts too! The App Center SDK also wraps everything up nicely so you don't have to worry about persisting the tokens returned by B2C - they'll be waiting for you whenever you ened them. It even handles signing the user in silently if they've signed in once already.

To sign-out users:

`Auth.SignOut()`

Seriously - super easy.

Check out the code in this repo and of course the episode to learn how to use everything. And the links to the docs will help you set everything up.
