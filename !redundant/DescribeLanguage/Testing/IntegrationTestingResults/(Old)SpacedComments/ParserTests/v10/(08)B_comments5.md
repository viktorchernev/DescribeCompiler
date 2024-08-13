========================================
Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> [https://www.notube.com/watch?v=hTui12lKus]-> // comment here

    wool fabrics <TcD3LcoW>,
    cotton fabrics[https://www.notube.com/watch?v=hTui12lKus] <thZBzyNc>,
    silk fabrics <dOlQGMJ4>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <Ln7Y7Dme>[https://www.notube.com/watch?v=hTui12lKus];// comment last🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── T(TAG|'<xpXWehDW> ')
│   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> // comment here\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   └── T(TAG|'<TcD3LcoW>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus] ')
│   │   │   │   └── T(TAG|'<thZBzyNc>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── T(TAG|'<dOlQGMJ4>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── T(TAG|'<Ln7Y7Dme>')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';// comment last')
└── T(EOF|'<EOF>')