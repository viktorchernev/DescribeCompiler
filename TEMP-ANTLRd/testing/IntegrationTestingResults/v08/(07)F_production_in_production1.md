========================================
Source Code (between the arrows)
========================================

🡆macronutrients <0CmyN2Mb> ->

    fiber <CMxWzMs5> ->

        what <hzAzwlx6>,
        not <UHOcZPAm>;
    
    water <BBmOZjJa>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── T(TAG|'<0CmyN2Mb> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── T(TAG|'<CMxWzMs5> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── T(TAG|'<hzAzwlx6>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── T(TAG|'<UHOcZPAm>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'water ')
│   │       └── T(TAG|'<BBmOZjJa>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')