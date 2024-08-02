---
layout: page
title: change-log
permalink: /v093/change-log
exclude: true
---
_change-log for v0.9.3_

IMPLEMENTED:
* Describe language version 1.0 (code-named "Describe Official") has been developed and tested and implemented in the current version. With this new version of describe we have a significantly more complex preprocessor, which allow for intuitive handling of special characters. For more information, see the specification on Describe Official v 1.0
* Preprocessor for Describe v1.0 has been developed
* Specific preprocessor for Describe v0.8 has been developed
* Specific preprocessor for Describe v0.7 has been developed
* Specific preprocessor for Describe v0.6 has been developed
* Optimizer for Describe v0.8 has been developed
* Specific optimizer for Describe v0.8 has been developed
* Specific optimizer for Describe v0.7 has been developed
* Specific optimizer for Describe v0.6 has been developed
* External templating functionality has been removed As there is no great interest in using the describe compiler with customized templates, this feature only hinders the development of the tool. Users are easily able to derive and code their own translators if needed.
* Refactoring has been done

FIXED:
* A bug with the implementation of custom decorators in the JSON translator have been removed
* CLI Showing proper "Press any key to exit" message, after parsing a folder
* CLI Changing console color on exit to what it was before execution
