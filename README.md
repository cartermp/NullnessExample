# NullnessExample

Shows the interaction between `Directory.build.props`, project files, and `#nullable` directives in source.

Here, nullness is globally enabled, opted out in one project, but a file within that project opts back in. Building the solution yields this:
