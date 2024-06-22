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
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>\n\n    ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'fiber')
│   │   │   │   └── T(SEPARATOR|',\n    ')
│   │   │   └── item
│   │   │       └── text_chunk
│   │   │           └── T(DATA|'water')
│   │   └── T(TERMINATOR|';\n\n')
│   └── expression
│       ├── item
│       │   └── text_chunk
│       │       └── T(DATA|'micronutrients ')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(PRODUCTION_ARROW|'>\n\n    ')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   └── text_chunk
│       │   │   │       └── T(DATA|'vitamins (ABCDEK)')
│       │   │   └── T(SEPARATOR|',\n    ')
│       │   └── item
│       │       └── text_chunk
│       │           └── T(DATA|'minerals (micronutrients)')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')