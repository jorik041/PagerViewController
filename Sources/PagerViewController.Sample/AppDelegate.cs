﻿using Foundation;
using UIKit;
using Pager;

namespace Pager.Sample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			var colors = new[]
			{
				UIColor.FromRGB(76,217,100),
				UIColor.FromRGB(52,170,220),
				UIColor.FromRGB(88,86,214),
             	UIColor.FromRGB(255,45,85),
			};

			var pages = new[]
			{
				new SamplePageViewController(colors[0]) { Title = "First" },
				new SamplePageViewController(colors[1]) { Title = "Second" },
				new SamplePageViewController(colors[2]) { Title = "Third" },
				new SamplePageViewController(colors[3]) { Title = "Last" },
			};

			var pager = new PagerViewController(new PagerStyle(PagerStyle.DotStretched) { SelectedStripColors = colors }, pages);

			var nav = new UINavigationController(pager);
			nav.NavigationBar.Translucent = false;

			this.Window = new UIWindow(UIScreen.MainScreen.Bounds);
			this.Window.RootViewController = nav;
			this.Window.MakeKeyAndVisible();

			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}

