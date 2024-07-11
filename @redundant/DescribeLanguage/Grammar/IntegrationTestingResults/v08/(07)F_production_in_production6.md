========================================
Source Code (between the arrows)
========================================

🡆macronutrients <VNvl4KbI> ->

    fiber <BNdiPBY8> ->

        what <47GG8irk>,
        not <vRje122z>;
	
	science <4Zohe6QE> ->
		
		math <u87kglXS> ->
			algebra <VB7KNYBw>,
			geometry <gKznl6RJ>;
			
		informathics <Uon0W1e7>,
		medicine <rBW9kGDK>;
    
    water <3QJz4slg>,
    salt <X2BTGncx>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── T(TAG|'<VNvl4KbI> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── T(TAG|'<BNdiPBY8> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── T(TAG|'<47GG8irk>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── T(TAG|'<vRje122z>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'science ')
│   │   │       │   └── T(TAG|'<4Zohe6QE> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   └── expression
│   │   │       │   │       ├── item
│   │   │       │   │       │   ├── text_chunk
│   │   │       │   │       │   │   └── T(DATA|'math ')
│   │   │       │   │       │   └── T(TAG|'<u87kglXS> ')
│   │   │       │   │       ├── producer
│   │   │       │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t')
│   │   │       │   │       ├── item_or_expression_list
│   │   │       │   │       │   ├── item_or_expression_part
│   │   │       │   │       │   │   ├── item
│   │   │       │   │       │   │   │   ├── text_chunk
│   │   │       │   │       │   │   │   │   └── T(DATA|'algebra ')
│   │   │       │   │       │   │   │   └── T(TAG|'<VB7KNYBw>')
│   │   │       │   │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │   │       │   │       │   └── item
│   │   │       │   │       │       ├── text_chunk
│   │   │       │   │       │       │   └── T(DATA|'geometry ')
│   │   │       │   │       │       └── T(TAG|'<gKznl6RJ>')
│   │   │       │   │       └── T(TERMINATOR|';\r\n\t\t\t\r\n\t\t')
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'informathics ')
│   │   │       │   │   │   └── T(TAG|'<Uon0W1e7>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'medicine ')
│   │   │       │       └── T(TAG|'<rBW9kGDK>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<3QJz4slg>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'salt ')
│   │       └── T(TAG|'<X2BTGncx>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')