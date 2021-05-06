const colors = require('tailwindcss/colors')
module.exports = {
  prefix: '',
  purge: {
    content: [
      './src/**/*.{html,ts}',
    ]
  },
  darkMode: 'class', // or 'media' or 'class'
  theme: {
    colors: {
      transparent: 'transparent',
      current: 'currentColor',
      black: colors.black,
      white: colors.white,
      gray: colors.trueGray,
      indigo: colors.indigo,
      green: colors.green,
      red: colors.rose,
      yellow: colors.amber,
      "primary": "#219653"

    },
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
