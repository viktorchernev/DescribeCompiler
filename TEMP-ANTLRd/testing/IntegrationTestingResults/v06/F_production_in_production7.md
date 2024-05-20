========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

	water,
    salt,
    fiber ->

        what,
        not;
	
	science ->
			
		informathics,
		medicine,
		
		math ->
			algebra,
			geometry;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'macronutrients ')
│   │   ├── item_or_expression_list
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'\n\n\twater')
│   │   │   ├── T(SEPARATOR|',')
│   │   │   └── item_or_expression_list
│   │   │       ├── item
│   │   │       │   └── text_chunk
│   │   │       │       └── T(DATA|'\n    salt')
│   │   │       ├── T(SEPARATOR|',')
│   │   │       └── item_or_expression_list
│   │   │           ├── item
│   │   │           │   ├── text_chunk
│   │   │           │   │   └── T(DATA|'\n    fiber ')
│   │   │           │   ├── text_chunk
│   │   │           │   │   └── T(HYPHEN|'-')
│   │   │           │   ├── text_chunk
│   │   │           │   │   └── T(RIGHT_ARROW|'>')
│   │   │           │   └── text_chunk
│   │   │           │       └── T(DATA|'\n\n        what')
│   │   │           ├── T(SEPARATOR|',')
│   │   │           └── item_or_expression
│   │   │               └── item
│   │   │                   └── text_chunk
│   │   │                       └── T(DATA|'\n        not')
│   │   └── T(TERMINATOR|';')
│   └── expression
│       ├── item
│       │   └── text_chunk
│       │       └── T(DATA|'\n\t\n\tscience ')
│       ├── item_or_expression_list
│       │   ├── item
│       │   │   └── text_chunk
│       │   │       └── T(DATA|'\n\t\t\t\n\t\tinformathics')
│       │   ├── T(SEPARATOR|',')
│       │   └── item_or_expression_list
│       │       ├── item
│       │       │   └── text_chunk
│       │       │       └── T(DATA|'\n\t\tmedicine')
│       │       ├── T(SEPARATOR|',')
│       │       └── item_or_expression_list
│       │           ├── item
│       │           │   ├── text_chunk
│       │           │   │   └── T(DATA|'\n\t\t\n\t\tmath ')
│       │           │   ├── text_chunk
│       │           │   │   └── T(HYPHEN|'-')
│       │           │   ├── text_chunk
│       │           │   │   └── T(RIGHT_ARROW|'>')
│       │           │   └── text_chunk
│       │           │       └── T(DATA|'\n\t\t\talgebra')
│       │           ├── T(SEPARATOR|',')
│       │           └── item_or_expression
│       │               └── item
│       │                   └── text_chunk
│       │                       └── T(DATA|'\n\t\t\tgeometry')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')