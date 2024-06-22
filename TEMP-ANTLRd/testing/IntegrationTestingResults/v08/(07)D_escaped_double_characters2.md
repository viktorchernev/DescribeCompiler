========================================
Source Code (between the arrows)
========================================

🡆fa \, br\->ics\// <6O4fovPJ>->

    wool\;fabrics <cTk1qeGz>,
    \,cotton fabrics\<<cTk1qeGz>,
    silk fabrics<cTk1qeGz>  ,
    synthetic fabrics\; <cTk1qeGz>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_SEPARATOR|'\, ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_LCOMMENT|'\// ')
│   │   └── T(TAG|'<6O4fovPJ>')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(TAG|'<cTk1qeGz>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\,')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_ARROW|'\<')
│   │   │   │   └── T(TAG|'<cTk1qeGz>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics')
│   │   │   │   └── T(TAG|'<cTk1qeGz>  ')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE_TERMINATOR|'\; ')
│   │       └── T(TAG|'<cTk1qeGz>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')