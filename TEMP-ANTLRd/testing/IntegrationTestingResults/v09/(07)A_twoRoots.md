========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'macronutrients ')
│   │   │   └── T(TAG|'<Zcm0y9mS> ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(RIGHT_ARROW|'>\n\n    ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'fiber ')
│   │   │   │   │   └── T(TAG|'<ZxMvmqeZ>')
│   │   │   │   └── T(SEPARATOR|',\n    ')
│   │   │   └── item
│   │   │       ├── text_chunk
│   │   │       │   └── T(DATA|'water ')
│   │   │       └── T(TAG|'<xePTheNI>')
│   │   └── T(TERMINATOR|';\n\n')
│   └── expression
│       ├── item
│       │   ├── text_chunk
│       │   │   └── T(DATA|'micronutrients ')
│       │   └── T(TAG|'<l7qy3zi2>')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(RIGHT_ARROW|'>\n\n    ')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(DATA|'vitamins (ABCDEK) ')
│       │   │   │   └── T(TAG|'<6Nq8AWj7>')
│       │   │   └── T(SEPARATOR|',\n    ')
│       │   └── item
│       │       ├── text_chunk
│       │       │   └── T(DATA|'minerals (micronutrients) ')
│       │       └── T(TAG|'<jG4U9bwg>')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')