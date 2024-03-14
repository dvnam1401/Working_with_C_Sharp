import { CssBaseline, Container, createTheme, ThemeProvider } from "@mui/material";
<<<<<<< HEAD
import Header from "./Header";
import { useState } from "react";
import { Outlet } from "react-router-dom";
=======
import Catalog from "../../features/catalog/Catalog";
import Header from "./Header";
import { useState } from "react";
>>>>>>> b07b1051943da71804a33dfb1026f118f49a9150

function App() {
  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light';
  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: paletteType === 'light' ? '#eaeaea' : '#121212'
      }
    }
  })

  function handleThemChange() {
    setDarkMode(!darkMode);
  }

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline></CssBaseline>
      <Header darkMode={darkMode} handleThemChange={handleThemChange} />
      <Container>
<<<<<<< HEAD
        <Outlet />
=======
        <Catalog />
>>>>>>> b07b1051943da71804a33dfb1026f118f49a9150
      </Container>
    </ThemeProvider>
  );
}

export default App