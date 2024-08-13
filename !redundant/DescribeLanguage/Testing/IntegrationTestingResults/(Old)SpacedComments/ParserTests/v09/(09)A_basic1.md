========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	http://fabrics.com wool [https://en.test.org/wiki/Wool] {}<54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton]{} <Ll0bDtIQ>,
	silk http://fabrics.com/index.html fabrics {}[https://en.test.org/wiki/Silk]<6huM44Hm>,
	synthetic fabrics{} [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

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
│   │   │   │   │   └── T(DATA|'http:')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASHES|'//')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics.com wool ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Wool] ')
│   │   │   │   ├── T(DECORATOR|'{}')
│   │   │   │   └── T(TAG|'<54vHCQwI>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Cotton]')
│   │   │   │   ├── T(DECORATOR|'{} ')
│   │   │   │   └── T(TAG|'<Ll0bDtIQ>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk http:')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASHES|'//')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics.com')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASH|'/')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'index.html fabrics ')
│   │   │   │   ├── T(DECORATOR|'{}')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Silk]')
│   │   │   │   └── T(TAG|'<6huM44Hm>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── T(DECORATOR|'{} ')
│   │       ├── T(LINK|'[https://en.test.org/wiki/Synthetic]')
│   │       └── T(TAG|'<oAgVUPi0>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')