---
layout: page
title: Namespace addressing scheme
permalink: /v09/features/feature-7
exclude: true
---
_FEATURE: Namespace addressing scheme_

The path addressing scheme in use right now does not work too good, or at least when we have people that need to edit the source files and start messing things up, sooner or later. It does work if we are relying on an IDE to manage the files for us. Namespace addressing is far superior - no wonder it is used in most OOP languages.

We also have other issues to figure out with the file path addressing: Shorten paths - "culture/@culture.ds/" to "culture/" or "culture.ds/" to "culture/" figure out backtracking tag paths "<../folder/tag>" to be resolved to standard paths?

However, there are no apparent benefits to using it instead of namespace addressing, and thus we should not, and not care about the issues above.
