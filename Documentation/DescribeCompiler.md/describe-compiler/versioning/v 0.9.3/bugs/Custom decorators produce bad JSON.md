# Custom decorators produce bad JSON
_BUG: Custom decorators produce bad JSON_

<span style="color:red">This is a bug in the inbuilt JSON translator in the API. The translator produces malformed JSON due to malformed template. Each decorator object needs to be placed in curly brackets, and those are missing from the inbuilt template.</span>

<span style="color:green">Code has been added to fix the issue.</span>
