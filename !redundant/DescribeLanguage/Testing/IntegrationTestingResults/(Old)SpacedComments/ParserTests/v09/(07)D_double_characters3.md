========================================
Source Code (between the arrows)
========================================

🡆fa \ br\ics\ <AkoHsBxP>->

    wool\fabrics <\2\2gPwg0Z>,
    \cotton fabrics <\6KbLpKF2>,
    \ silk \ fabrics <YA0\Cn7gP>,
    synthetic fabrics\ <V4tLOkb5>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE|'\ ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE|'\')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ics')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE|'\ ')
│   │   └── T(TAG|'<AkoHsBxP>')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(TAG|'<\2\2gPwg0Z>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── T(TAG|'<\6KbLpKF2>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE|'\ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(TAG|'<YA0\Cn7gP>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics')
│   │       ├── text_chunk
│   │       │   └── T(ESCAPE|'\ ')
│   │       └── T(TAG|'<V4tLOkb5>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')