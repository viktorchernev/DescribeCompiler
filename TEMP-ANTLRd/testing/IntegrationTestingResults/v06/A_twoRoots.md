========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber,
    water;

micronutrients ->

    vitamins (ABCDEK),
    minerals (micronutrients);🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'macronutrients ')
│   │   ├── item_or_expression_list
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'

    fiber')
│   │   │   ├── T(SEPARATOR|',')
│   │   │   └── item_or_expression
│   │   │       └── item
│   │   │           └── text_chunk
│   │   │               └── T(DATA|'
    water')
│   │   └── T(TERMINATOR|';')
│   └── expression
│       ├── item
│       │   └── text_chunk
│       │       └── T(DATA|'

micronutrients ')
│       ├── item_or_expression_list
│       │   ├── item
│       │   │   └── text_chunk
│       │   │       └── T(DATA|'

    vitamins (ABCDEK)')
│       │   ├── T(SEPARATOR|',')
│       │   └── item_or_expression
│       │       └── item
│       │           └── text_chunk
│       │               └── T(DATA|'
    minerals (micronutrients)')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')