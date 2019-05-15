# NullnessExample

Shows the interaction between `Directory.build.props`, project files, and `#nullable` directives in source.

Here, nullness is globally enabled, opted out in one project, but a file within that project opts back in. Building the solution yields this:

![](https://user-images.githubusercontent.com/6309070/57787458-42674600-76ea-11e9-911c-a456e787fc21.png)
