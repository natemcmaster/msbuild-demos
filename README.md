msbuild-brownbag
----------------


Quirks:

In MSBuild, order matters...sometimes.

x-plat: MSBuild maps file separators to the appropriate character.
By convention, you should always use '\'. MSBuild will map that to '/' on Linux.