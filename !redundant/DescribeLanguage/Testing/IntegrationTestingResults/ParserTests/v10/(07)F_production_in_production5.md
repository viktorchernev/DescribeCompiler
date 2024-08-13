========================================
Source Code (between the arrows)
========================================

🡆macronutrients <SxOf3elF> ->

	water <8S3IwDlG>,
    salt <RV4OUQoy>,
    fiber <G3tWgyDr> ->

        what <AwPl7oBK>,
        not <OcIUTGif>;
	
	science <k543P1uB> ->
		
		math <IZZ9vPiK>,
		informathics <OMH9y9Jn>,
		medicine <UuA1ITf9>;
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
│   │   └── T(TAG|'<SxOf3elF> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<8S3IwDlG>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt ')
│   │   │   │   └── T(TAG|'<RV4OUQoy>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── T(TAG|'<G3tWgyDr> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── T(TAG|'<AwPl7oBK>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── T(TAG|'<OcIUTGif>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science ')
│   │       │   └── T(TAG|'<k543P1uB> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'math ')
│   │       │   │   │   └── T(TAG|'<IZZ9vPiK>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics ')
│   │       │   │   │   └── T(TAG|'<OMH9y9Jn>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'medicine ')
│   │       │       └── T(TAG|'<UuA1ITf9>')
│   │       └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')