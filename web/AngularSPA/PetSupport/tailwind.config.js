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
      indigo: colors.indigo,
      red: colors.rose,
      yellow: {
        DEFAULT: "#F2C94C",
        dark: "#F8C21D",
        light: "#F3D473",
        lightest: "#F3DD98",
        normal: colors.amber,
      },
      green: {
        DEFAULT: "#219653",
        dark: "#046A2F",
        light: "#49B678",
        lightest: "#8ACBA6",
        normal: colors.green,
      },
      gray: {
        DEFAULT: "#848484",
        darkest: "#4A4A4A",
        light: "#B9B9B9",
        lightest: "#D4D4D4",
        normal: colors.trueGray,
      }
    },

    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
