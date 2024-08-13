========================================
Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;
;
🡄

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
│   │   │   └── T(DATA|'eQxYylc3')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'tdgS8qBO')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'fiber ')
│   │       │   ├── text_chunk
│   │       │   │   └── T(LEFT_ARROW|'<')
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'OpdFntBx')
│   │       │   └── text_chunk
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'what ')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'MLUxjdg8')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'not ')
│   │       │       ├── text_chunk
│   │       │       │   └── T(LEFT_ARROW|'<')
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'qkVgxZIs')
│   │       │       └── text_chunk
│   │       │           └── T(RIGHT_ARROW|'>')
│   │       └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')