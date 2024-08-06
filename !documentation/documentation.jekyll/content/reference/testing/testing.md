---
layout: page
title: Describe Transpiler - Testing
permalink: /testing/
exclude: true
---
<br>
## Grammars

1. We have devised (and are devising) describe source code test files (.ds) that aim to test various different scenarios for each version of the Describe grammar.

2. We parse those test files using the GOLD parser engine with the specific grammar tables version being tested and make sure that they are all parsed successfully. We are also running all the tests for all the previous versions, as grammars need to be backward compatible. The log output is documented.

3. We parse those test files using the GOLD Builder, making sure they are all parsed successfully. We are also running all the tests for all the previous versions, as grammars need to be backward compatible. The log output is documented.

4. The log outputs from the two different methods are compared, making sure the parsing process produced the same result in all the test cases.

<br>
### Links
[Grammar v0.6](/testing/grammar-v06)<br>
[Grammar v0.7](/testing/grammar-v07)<br>
[Grammar v0.8](/testing/grammar-v08)<br>
[Grammar v0.9](/testing/grammar-v09)<br>
[Grammar v1.0](/testing/grammar-v10)<br>
[Back](/language/reference)