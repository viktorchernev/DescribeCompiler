========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n    wool fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'\n    cotton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'\n    silk fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    synthetic fabrics')
│   └── T(TERMINATOR|';')
├── text_chunk
│   └── T(NEWLINE|'\n')
└── T(EOF|'<EOF>')