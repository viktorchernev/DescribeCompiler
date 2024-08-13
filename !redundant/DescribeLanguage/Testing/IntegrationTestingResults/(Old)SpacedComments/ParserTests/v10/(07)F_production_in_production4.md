========================================
Source Code (between the arrows)
========================================

🡆macronutrients <xkQxOfc9> ->

    fiber <CbALGP8d> ->

        what <7KNUmetK>,
        not <6qFQ0HxK>;
	
	science <o8lvOnlB> ->
		
		math <SbQjE2YS>,
		informathics <CVOSiiAS>,
		medicine <1G0hZLJ4>;
    
    water <ozhHnNOU>,
    salt <jMBLOKGE>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── T(TAG|'<xkQxOfc9> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── T(TAG|'<CbALGP8d> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── T(TAG|'<7KNUmetK>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── T(TAG|'<6qFQ0HxK>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'science ')
│   │   │       │   └── T(TAG|'<o8lvOnlB> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\r\n\t\t')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'math ')
│   │   │       │   │   │   └── T(TAG|'<SbQjE2YS>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'informathics ')
│   │   │       │   │   │   └── T(TAG|'<CVOSiiAS>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'medicine ')
│   │   │       │       └── T(TAG|'<1G0hZLJ4>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<ozhHnNOU>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'salt ')
│   │       └── T(TAG|'<jMBLOKGE>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')