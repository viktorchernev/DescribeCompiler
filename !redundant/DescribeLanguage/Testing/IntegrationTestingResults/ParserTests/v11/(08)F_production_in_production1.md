========================================
Source Code (between the arrows)
========================================

🡆macronutrients <0CmyN2Mb> ->

    fiber <CMxWzMs5> ->

        what [http://testlink.com/]<hzAzwlx6>,
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
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'0CmyN2Mb')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(LEFT_ARROW|'<')
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'CMxWzMs5')
│   │   │       │   └── text_chunk
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(LEFT_SQUARE|'[')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'http')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(PROTO_SLASHES|'://')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'testlink.com')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(FORWARD_SLASH|'/')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(RIGHT_SQUARE|']')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'hzAzwlx6')
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(LEFT_ARROW|'<')
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'UHOcZPAm')
│   │   │       │       └── text_chunk
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'water ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_ARROW|'<')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'BBmOZjJa')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')