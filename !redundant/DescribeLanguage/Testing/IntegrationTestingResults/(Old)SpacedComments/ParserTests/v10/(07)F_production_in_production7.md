========================================
Source Code (between the arrows)
========================================

🡆macronutrients <ryQ27h6e> ->

	water <hAdLCBLZ>,
    salt <GotVxcPm>,
    fiber <CHcd0L0E> ->

        what <jiSw0LNV>,
        not <TpR3PZdW>;
	
	science <qlMb3HAO> ->
			
		informathics <jn0zFcnW>,
		medicine <JZmdtZj5>,
		
		math <bYBIKVXn> ->
			algebra <nFxP8YKb>,
			geometry <hDNMVYP0>;
;
;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── T(TAG|'<ryQ27h6e> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<hAdLCBLZ>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt ')
│   │   │   │   └── T(TAG|'<GotVxcPm>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── T(TAG|'<CHcd0L0E> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── T(TAG|'<jiSw0LNV>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── T(TAG|'<TpR3PZdW>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science ')
│   │       │   └── T(TAG|'<qlMb3HAO> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics ')
│   │       │   │   │   └── T(TAG|'<jn0zFcnW>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'medicine ')
│   │       │   │   │   └── T(TAG|'<JZmdtZj5>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t\r\n\t\t')
│   │       │   └── expression
│   │       │       ├── item
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(DATA|'math ')
│   │       │       │   └── T(TAG|'<bYBIKVXn> ')
│   │       │       ├── producer
│   │       │       │   ├── T(HYPHEN|'-')
│   │       │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\t')
│   │       │       ├── item_or_expression_list
│   │       │       │   ├── item_or_expression_part
│   │       │       │   │   ├── item
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(DATA|'algebra ')
│   │       │       │   │   │   └── T(TAG|'<nFxP8YKb>')
│   │       │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │       │       │   └── item
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(DATA|'geometry ')
│   │       │       │       └── T(TAG|'<hDNMVYP0>')
│   │       │       └── T(TERMINATOR|';\n')
│   │       └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')