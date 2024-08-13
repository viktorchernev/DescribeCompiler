========================================
Source Code (between the arrows)
========================================

🡆fabrics <qJobcYNC> -> // comment here

    wool fabrics <WmtITd8B>,
    cotton fabrics <KGkvDUZH>,
    silk fabrics <BbiZz4Ie>,
    synthetic fabrics <gCWv1P46>;

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
│   │   │   │   └── T(TAG|'<WmtITd8B>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── T(TAG|'<KGkvDUZH>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   └── T(TAG|'<BbiZz4Ie>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── T(TAG|'<gCWv1P46>')
│   └── T(TERMINATOR|';\r\n\r\n')
└── T(EOF|'<EOF>')