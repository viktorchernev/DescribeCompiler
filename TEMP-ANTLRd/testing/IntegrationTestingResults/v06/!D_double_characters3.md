line 1:3 token recognition error at: '\ '
line 1:7 token recognition error at: '\i'
line 1:11 token recognition error at: '\ '
line 3:8 token recognition error at: '\f'
line 4:4 token recognition error at: '\c'
line 5:4 token recognition error at: '\ '
line 5:11 token recognition error at: '\ '

Add BACHWARD_SLASH : "\\" ; to the grammar
Rename FIRWARD_SLASH to FORWARD_SLASH

========================================
Source Code (between the arrows)
========================================

🡆fa \ br\ics\ ->

    wool\fabrics,
    \cotton fabrics,
    \ silk \ fabrics,
    synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   └── text_chunk
│   │       └── T(DATA|'cs')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'\n\n    wool')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'abrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'\n    ')
│   │       │   └── text_chunk
│   │       │       └── T(DATA|'otton fabrics')
│   │       ├── T(SEPARATOR|',')
│   │       └── item_or_expression_list
│   │           ├── item
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'\n    ')
│   │           │   ├── text_chunk
│   │           │   │   └── T(DATA|'silk ')
│   │           │   └── text_chunk
│   │           │       └── T(DATA|'fabrics')
│   │           ├── T(SEPARATOR|',')
│   │           └── item_or_expression
│   │               └── item
│   │                   └── text_chunk
│   │                       └── T(DATA|'\n    synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')