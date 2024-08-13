========================================
Source Code (between the arrows)
========================================

🡆fabrics<wIcCuax5>[https://www.notube.com/watch?v=hTui12lKus]->

    wool fabrics[https://www.notube.com/watch?v=hTui12lKus]<C92Mf6yV>,
	
    cotton fabrics<TxW3Yetp> {color | green}
	[https://www.notube.com/watch?v=hTui12lKus]
	[https://www.notube.com/watch?v=hTui12lKus],

    silk fabrics (https://www.notube.com/watch?v=hTui12lKus) <08yGbnMX>,
    synthetic fabrics (ftp://www.notube.com/watch?v=hTui12lKus)<7MZTHLMY>;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics')
│   │   ├── T(TAG|'<wIcCuax5>')
│   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   │   └── T(TAG|'<C92Mf6yV>')
│   │   │   └── T(SEPARATOR|',\r\n\t\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics')
│   │   │   │   ├── T(TAG|'<TxW3Yetp> ')
│   │   │   │   ├── T(DECORATOR|'{color | green}\r\n\t')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]\r\n\t')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics (https')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(PROTO_SLASHES|'://')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'www.notube.com')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASH|'/')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'watch?v=hTui12lKus) ')
│   │   │   │   └── T(TAG|'<08yGbnMX>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics (ftp')
│   │       ├── text_chunk
│   │       │   └── T(PROTO_SLASHES|'://')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'www.notube.com')
│   │       ├── text_chunk
│   │       │   └── T(FORWARD_SLASH|'/')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'watch?v=hTui12lKus)')
│   │       └── T(TAG|'<7MZTHLMY>')
│   └── T(TERMINATOR|';\r\n')
└── T(EOF|'<EOF>')