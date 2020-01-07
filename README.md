# SwipeViewCrashRepro
A reproduction sample of Xamarin.Forms.iOS.SwipeViewRenderer NullReferenceException: `UIStringDrawing.StringSize (System.String This, UIKit.UIFont font) SIGABRT: Object reference not set to an instance of an object`

```
System.NullReferenceException: Object reference not set to an instance of an object
  at UIKit.UIStringDrawing.StringSize (Foundation.NSString This, UIKit.UIFont font) [0x00068] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.6.0.12/src/Xamarin.iOS/UIStringDrawing.g.cs:230
  at UIKit.UIStringDrawing.StringSize (System.String This, UIKit.UIFont font) [0x00007] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.6.0.12/src/Xamarin.iOS/UIKit/UIStringDrawing.cs:65
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.UpdateSwipeItemInsets (UIKit.UIButton button, System.Single spacing) [0x00067] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:393
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.CreateSwipeItem (Xamarin.Forms.SwipeItem formsSwipeItem) [0x00051] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:354
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.UpdateSwipeItems () [0x00103] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:311
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.ProcessTouchMove (CoreGraphics.CGPoint point) [0x00083] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:511
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.HandleTouchInteractions (Xamarin.Forms.GestureStatus status, CoreGraphics.CGPoint point) [0x00021] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:469
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.HandleTouchInteractions (Foundation.NSSet touches, Xamarin.Forms.GestureStatus gestureStatus) [0x0002a] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:458
  at Xamarin.Forms.Platform.iOS.SwipeViewRenderer.TouchesMoved (Foundation.NSSet touches, UIKit.UIEvent evt) [0x00000] in D:\a\1\s\Xamarin.Forms.Platform.iOS\Renderers\SwipeViewRenderer.cs:208
  at at (wrapper managed-to-native) UIKit.UIApplication.UIApplicationMain(int,string[],intptr,intptr)
  at UIKit.UIApplication.Main (System.String[] args, System.IntPtr principal, System.IntPtr delegate) [0x00005] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.6.0.12/src/Xamarin.iOS/UIKit/UIApplication.cs:86
  at UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x0000e] in /Library/Frameworks/Xamarin.iOS.framework/Versions/13.6.0.12/src/Xamarin.iOS/UIKit/UIApplication.cs:65
  at SwipeRendererRepro.iOS.Application.Main (System.String[] args) [0x00000] in /Users/bramin/Projects/SwipeRendererRepro/SwipeRendererRepro.iOS/Main.cs:7
```

## Reproduction Steps

1. Download/close this repo
2. In Visual Studio, open `SwipeRendererRepro.sln`
3. In Visual Studio, build/deploy `SwipeRendererRepro.iOS` to an iOS Simulator or Device
4. On the iOS app, on the yellow `Label`, swipe left-to-right
5. On the iOS app, confirm the `SwipeItem` is working properly 
6. On the iOS app, click the green `Test` text to dismiss the `SwipeItem`
7. On the iOS app, on the yellow `Label`, swipe right-to-left
8. Confrim the app crashes

## Environment

=== Visual Studio Enterprise 2019 for Mac ===

Version 8.3.11 (build 1)
Installation UUID: d03a9496-0fde-4bad-85bd-1ff8c31cf324
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.16.1.24 (d16-3 / 08809f5b)

	Package version: 604000208

=== Mono Framework MDK ===

Runtime:
	Mono 6.4.0.208 (2019-06/07c23f2ca43) (64-bit)
	Package version: 604000208

=== NuGet ===

Version: 5.3.0.6192

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.1.100/Sdks
SDK Versions:
	3.1.100
	3.0.101
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.4.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.1.0
	3.0.1
	2.1.14

=== Xamarin.Profiler ===

Version: 1.6.12.29
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 11.3 (15712)
Build 11C29

=== Xamarin.Mac ===

Xamarin.Mac not installed. Can't find /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/Version.

=== Xamarin.iOS ===

Version: 13.6.0.12 (Visual Studio Enterprise)
Hash: e3c2b406d
Branch: xcode11.2
Build date: 2019-11-01 00:12:08-0400

=== Xamarin Designer ===

Version: 16.3.0.256
Hash: 8a223bfd7
Branch: remotes/origin/d16-3
Build date: 2019-11-01 21:02:02 UTC

=== Xamarin.Android ===

Version: 10.0.6.2 (Visual Studio Enterprise)
Commit: xamarin-android/d16-3/c407838
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		None installed

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 29.0.5
SDK Build Tools Version: 29.0.2

Build Information: 
Mono: mono/mono/2019-06@476d72b9e32
Java.Interop: xamarin/java.interop/d16-3@5836f58
LibZipSharp: grendello/LibZipSharp/d16-3@71f4a94
LibZip: nih-at/libzip/rel-1-5-1@b95cf3fd
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.27.1@8212a2d
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-3@cb41333

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 1.4.0.65
Hash: c33b107
Branch: remotes/origin/d16-3
Build date: 2019-11-19 20:33:22 UTC

=== Android Device Manager ===

Version: 1.2.0.116
Hash: d2b2af0
Branch: remotes/origin/d16-3
Build date: 2019-11-19 20:33:42 UTC

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 803110001
Git revision: 6ee6ad2ec46ae5a08a1999ee4c815ac656a35b91
Build date: 2019-12-05 16:09:27+00
Build branch: release-8.3
Xamarin extensions: 56bd70ef2e327f71c615cfc29a47fd50685fadcb

=== Operating System ===

Mac OS X 10.15.2
Darwin 19.2.0 Darwin Kernel Version 19.2.0
    Sat Nov  9 03:47:04 PST 2019
    root:xnu-6153.61.1~20/RELEASE_X86_64 x86_64


