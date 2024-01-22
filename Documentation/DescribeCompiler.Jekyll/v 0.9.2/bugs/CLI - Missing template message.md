---
layout: page
title: CLI - Missing template message
permalink: /v092/bugs/bug-2
exclude: true
---
_BUG: Missing template message_

<span style="color:red">When a template is selected via command line and the template is not present in the templates folder (or there is no templates folder) we still get the message that the template is selected and we get no message whatsoever about the issue and get the default template used instead. In ```UnfoldTranslator.Ctor```</span>

<span style="color:green">Code has been refactored and issue has been fixed.</span>
