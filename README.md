# FanavardTest

 * Operating System: Virtually anything that can run .net core, .net framework and probably recent versions of mono. This includes Windows, Linux, Mac, and most BSDs.  

 * Written in C# using .net core 3.1. Can be efforttlessly ported to any version of .net core higher than netfx 2.0 (uses generics and linq which would need to be slightly altered or rewritten)

 * No additional libraries other than .net core's `System` and `System.Linq` (which are shipped by default) are used.

 * No databases of any kind are used within this project. (as of 2021/jan/26)

 * dotnet core stable release 3.1(3.1.100 is current as of now) can be invoked to compile this project like `dotnet build`. In case anyone bothers to port it to other frameworks, You may try `mcs`, `gmcs` and `mono`
 
  

 ## How it works


* although the problem is extremely simple and the solution self-explanatory We're gonna go through the steps taken to solve it:
 
 After reading the input we first iterate through all possible starting points for the given set of items from the 1st to last to determine wich items can fit in the boxes and we add them up until we either run out of items or boxes. After each iteration we compare our results with our previous best and if it's better than the previous best we then use the current run's results as best.  
 At the end we print the best result(which is how many items can we fit in the given boxes at most if we skip an item every time we can't fit it all properly).
 
 The source code is located at https://github.com/BehroozAmoozad/FanavardTest
