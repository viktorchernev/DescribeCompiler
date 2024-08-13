========================================
Source Code (between the arrows)
========================================

🡆fa \\ br\\ics\\ <rDD37re8> ->

    wool\\fabrics <uCzQa1uW>,
    \\cotton fabrics <UxMKgYjI>,
    \\ silk \\ fabrics <Ux6wwQBT>,
    synthetic fabrics\\ <dbpyUcza>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\ ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_ESCAPE|'\\ ')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'rDD37re8')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'uCzQa1uW')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'UxMKgYjI')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_ESCAPE|'\\ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'Ux6wwQBT')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE_ESCAPE|'\\ ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_ARROW|'<')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'dbpyUcza')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')