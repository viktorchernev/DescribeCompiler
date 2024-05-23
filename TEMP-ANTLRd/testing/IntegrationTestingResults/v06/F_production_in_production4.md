========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
	
	science ->
		
		math,
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
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── expression
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'\n\n    fiber ')
│   │   │   ├── producer
│   │   │   │   ├── T(HYPHEN|'-')
│   │   │   │   └── T(RIGHT_ARROW|'>')
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
│   │       │   ├── producer
│   │       │   │   ├── T(HYPHEN|'-')
│   │       │   │   └── T(RIGHT_ARROW|'>')
│   │       │   ├── item_or_expression_list
│   │       │   │   ├── item
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(DATA|'\n\t\t\n\t\tmath')
│   │       │   │   ├── T(SEPARATOR|',')
│   │       │   │   └── item_or_expression_list
│   │       │   │       ├── item
│   │       │   │       │   └── text_chunk
│   │       │   │       │       └── T(DATA|'\n\t\tinformathics')
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