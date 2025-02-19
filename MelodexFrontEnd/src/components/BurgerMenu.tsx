import * as React from 'react';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Button from '@mui/material/Button';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemText from '@mui/material/ListItemText';
import { useNavigate } from 'react-router-dom';

type MenuItem = {
    text: string;
    path: string;
  };
  
interface BurgerMenuProps {
    elements: MenuItem[];
}

export default function BurgerMenu ({elements}: BurgerMenuProps) {
    const [open, setOpen] = React.useState(false);
    const navigate = useNavigate();

    const DrawerList = (
        <Box sx={{ width: 250 }} role="presentation" onClick={()=>setOpen(false)}>
        <List>
          {elements.map(({ text, path }) => (
            <ListItem key={text} disablePadding>
              <ListItemButton onClick={() => navigate(path)}>
                <ListItemText primary={text} />
              </ListItemButton>
            </ListItem>
          ))}
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