/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./dist/*.{html,js}'],
  theme: {
    extend: {
      colors: {
        rDark: '#030303',
        rDarkGray: '#1a1a1b',
        rMedGray: '#272729',
        rNavDark: '#1a1a1b',
        rLighterGray: '#2a2a2b',
        rVeryLightGray: '#626267',
      }
    },
  },
  plugins: [],
}
