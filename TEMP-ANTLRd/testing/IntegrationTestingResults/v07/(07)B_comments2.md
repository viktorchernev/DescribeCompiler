========================================
Source Code (between the arrows)
========================================

🡆fabrics <aXLBEer9> -> // comment here

    /* wool fabrics <VevA2Eh3>, */
    cotton fabrics <evhAIQx4>,
    silk fabrics <h0e5wwEY>,
    synthetic fabrics <WryZrSIJ>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── T(TAG|'<aXLBEer9> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── T(TAG|'<evhAIQx4>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   └── T(TAG|'<h0e5wwEY>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── T(TAG|'<WryZrSIJ>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')