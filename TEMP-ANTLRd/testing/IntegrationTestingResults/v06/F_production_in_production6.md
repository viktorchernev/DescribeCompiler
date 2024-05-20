========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
	
	science ->
		
		math ->
			algebra,
			geometry;
			
		informathics,
		medicine;
    
    water,
    salt;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'macronutrients ')
│   ├── item_or_expression_list
│   │   ├── expression
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'\n\n    fiber ')
│   │   │   ├── item_or_expression_list
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'\n\n        what')
│   │   │   │   ├── T(SEPARATOR|',')
│   │   │   │   └── item_or_expression
│   │   │   │       └── item
│   │   │   │           └── text_chunk
│   │   │   │               └── T(DATA|'\n        not')
│   │   │   └── T(TERMINATOR|';')
│   │   └── item_or_expression_list
│   │       ├── expression
│   │       │   ├── item
│   │       │   │   └── text_chunk
│   │       │   │       └── T(DATA|'\n\t\n\tscience ')
│   │       │   ├── item_or_expression_list
│   │       │   │   ├── expression
│   │       │   │   │   ├── item
│   │       │   │   │   │   └── text_chunk
│   │       │   │   │   │       └── T(DATA|'\n\t\t\n\t\tmath ')
│   │       │   │   │   ├── item_or_expression_list
│   │       │   │   │   │   ├── item
│   │       │   │   │   │   │   └── text_chunk
│   │       │   │   │   │   │       └── T(DATA|'\n\t\t\talgebra')
│   │       │   │   │   │   ├── T(SEPARATOR|',')
│   │       │   │   │   │   └── item_or_expression
│   │       │   │   │   │       └── item
│   │       │   │   │   │           └── text_chunk
│   │       │   │   │   │               └── T(DATA|'\n\t\t\tgeometry')
│   │       │   │   │   └── T(TERMINATOR|';')
│   │       │   │   └── item_or_expression_list
│   │       │   │       ├── item
│   │       │   │       │   └── text_chunk
│   │       │   │       │       └── T(DATA|'\n\t\t\t\n\t\tinformathics')
│   │       │   │       ├── T(SEPARATOR|',')
│   │       │   │       └── item_or_expression
│   │       │   │           └── item
│   │       │   │               └── text_chunk
│   │       │   │                   └── T(DATA|'\n\t\tmedicine')
│   │       │   └── T(TERMINATOR|';')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n    \n    water')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    salt')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')