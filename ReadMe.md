## Summary
##### Variable defined with “using declaration” is disposed at the end of the enclosing scope.
##### Curly braces and brackets are reduced in the code block.
##### In the case of a using statement, we have control over defining the scope of the object. In the case of a using declaration, its scope is automatically defined from the object’s declaration statement to the end of the current code block.
##### using declaration keeps the variable in scope all the way to the bottom of the method. So using statement will make more sense to use because the object will be disposed of at the using statement ending brace.
