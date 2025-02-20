import * as React from 'react';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Button from '@mui/material/Button';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemText from '@mui/material/ListItemText';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../contexts/AuthContext';

type MenuItem = {
    text: string;
    path: string;
  };
  
interface BurgerMenuProps {
  menuOptions: MenuItem[];
}

export default function BurgerMenu ({menuOptions}: BurgerMenuProps) {
    const [open, setOpen] = React.useState(false);
    const navigate = useNavigate();
    const {logout} = useAuth();

    const DrawerList = (
        <Box sx={{ width: 250 }} role="presentation" onClick={()=>setOpen(false)}>
        <List>
          {menuOptions.map(({ text, path }) => (
            <ListItem key={text} disablePadding>
              <ListItemButton onClick={() => text=='logout'? logout(): navigate(path)}>
                <ListItemText primary={text} />
              </ListItemButton>
            </ListItem>
            
          ))}
          <ListItem>
            <ListItemButton onClick={() => logout()}>
              <ListItemText primary={'Logout'} />
            </ListItemButton>
          </ListItem>
        </List>
      </Box>
    );

    return (
        <div style={{ position: 'fixed', top: '10px', left: '10px', zIndex: 1000 }}>
            <Button style={{fontSize: '30px', color: 'white'}} onClick={()=>setOpen(true)}>☰</Button>
            <Drawer open={open} onClose={()=>setOpen(false)}>
            {DrawerList}
            </Drawer>
        </div>
    );
}