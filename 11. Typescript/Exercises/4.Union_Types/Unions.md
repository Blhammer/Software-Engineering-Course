I have learned:

-   I can combine two types with a vertical bar character |. This is the syntax for defining a union. Each type in a union is called a type member.
-   I can narrow down what methods and properties are available in a program with type narrowing. Type narrowing allows us to type a variable as a union, then narrow down the union with a type guard to call type member specific methods and properties.
-   If a function can return multiple types, TypeScript will infer all possible return types as a union.
-   I can use unions to allow arrays to have multiple types of values.
-   To call a method or property on a variable typed as a union, we can only call methods or properties that are identical on all members of the union.
-   I can define states within our program by using literal types and unions.
