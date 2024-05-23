========================================
Source Code (between the arrows)
========================================

🡆fa / br/ics/ ->

    wool/fabrics,
    /cotton fabrics,
    / silk / fabrics,
    synthetic fabrics/;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(FIRWARD_SLASH|'/')
│   │   ├── text_chunk
│   │   │   └── T(DATA|' br')
│   │   ├── text_chunk
│   │   │   └── T(FIRWARD_SLASH|'/')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(FIRWARD_SLASH|'/')
│   │   └── text_chunk
│   │       └── T(DATA|' ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'\n\n    wool')
│   │   │   ├── text_chunk
│   │   │   │   └── T(FIRWARD_SLASH|'/')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'\n    ')
│   │       │   ├── text_chunk
│   │       │   │   └── T(FIRWARD_SLASH|'/')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'cotton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'\n    ')
│   │           │   ├── text_chunk
│   │           │   │   └── T(FIRWARD_SLASH|'/')
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|' silk ')
│   │           │   ├── text_chunk
│   │           │   │   └── T(FIRWARD_SLASH|'/')
│   │           │   └── text_chunk
│   │           │       └── T(DATA|' fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   ├── text_chunk
│   │                   │   └── T(DATA|'\n    synthetic fabrics')
│   │                   └── text_chunk
│   │                       └── T(FIRWARD_SLASH|'/')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')