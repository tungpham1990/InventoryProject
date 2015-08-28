package springweb.controllers;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

@Controller
@RequestMapping("/")
public class HomeController {

    private final static Logger logger = LoggerFactory.getLogger(HomeController.class);

    @RequestMapping
    public ModelAndView index()
    {
        ModelAndView mv = new ModelAndView("pages/home");
        return mv;
    }

    @RequestMapping(value = "home", method = RequestMethod.GET)
    public ModelAndView welcome(ModelMap model)
    {
        ModelAndView mv = new ModelAndView("pages/home");
        return mv;
    }
}