========================================
Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> // comment here

    wool fabrics <WmtITd8B>[https://www.notube.com/watch?v=hTui12lKus],
    cotton fabrics <KGkvDUZH>[https://www.notube.com/watch?v=hTui12lKus],
    silk fabrics <BbiZz4Ie>[https://www.notube.com/watch?v=hTui12lKus],
    synthetic fabrics <gCWv1P46>[https://www.notube.com/watch?v=hTui12lKus];

// comment last🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── T(TAG|'<qJobcYNC> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> // comment here\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── T(TAG|'<WmtITd8B>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(TAG|'<KGkvDUZH>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── T(TAG|'<BbiZz4Ie>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── T(TAG|'<gCWv1P46>')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';\r\n\r\n')
└── T(EOF|'<EOF>')