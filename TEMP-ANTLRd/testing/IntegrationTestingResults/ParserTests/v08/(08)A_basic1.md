========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>,
	silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>,
	synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── T(LINK|'[https://en.test.org/wiki/List_of_fabrics] ')
│   │   └── T(TAG|'<QpeudYXy> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Wool | wikipedia] ')
│   │   │   │   └── T(TAG|'<54vHCQwI>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Cotton] ')
│   │   │   │   └── T(TAG|'<Ll0bDtIQ>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Silk | test.org]')
│   │   │   │   └── T(TAG|'<6huM44Hm>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── T(LINK|'[https://en.test.org/wiki/Synthetic]')
│   │       └── T(TAG|'<oAgVUPi0>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')