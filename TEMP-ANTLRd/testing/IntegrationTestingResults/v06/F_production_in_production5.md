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
		
		math,
		informathics,
		medicine;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'macronutrients ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(RIGHT_ARROW|'>')
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
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(RIGHT_ARROW|'>')
│       ├── item_or_expression_list
│       │   ├── item
│       │   │   └── text_chunk
│       │   │       └── T(DATA|'\n\t\t\n\t\tmath')
│       │   ├── T(SEPARATOR|',')
│       │   └── item_or_expression_list
│       │       ├── item
│       │       │   └── text_chunk
│       │       │       └── T(DATA|'\n\t\tinformathics')
│       │       ├── T(SEPARATOR|',')
│       │       └── item_or_expression
│       │           └── item
│       │               └── text_chunk
│       │                   └── T(DATA|'\n\t\tmedicine')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')