========================================
Source Code (between the arrows)
========================================

🡆fabrics<wIcCuax5>[https://www.notube.com/watch?v=hTui12lKus]->

    wool fabrics[https://www.notube.com/watch?v=hTui12lKus]<C92Mf6yV>,
	
    cotton fabrics<TxW3Yetp>
	[https://www.notube.com/watch?v=hTui12lKus | notube]
	[https://www.notube.com/watch?v=hTui12lKus | yestube],

    silk fabrics<08yGbnMX>,
    synthetic fabrics<7MZTHLMY>;
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
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
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
│   │   │   │   ├── T(TAG|'<TxW3Yetp>\r\n\t')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus | notube]\r\n\t')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus | yestube]')
│   │   │   └── T(SEPARATOR|',\r\n\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics')
│   │   │   │   └── T(TAG|'<08yGbnMX>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       └── T(TAG|'<7MZTHLMY>')
│   └── T(TERMINATOR|';\r\n')
└── T(EOF|'<EOF>')