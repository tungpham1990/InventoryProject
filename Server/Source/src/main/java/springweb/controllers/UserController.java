package springweb.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.support.SessionStatus;
import org.springframework.web.servlet.ModelAndView;
import springweb.entities.UserInfo;
import springweb.services.UserInfoService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/user")
public class UserController {

    @Autowired
    private UserInfoService userInfoService;

    @RequestMapping(value="/authorization", method=RequestMethod.GET , produces={"application/json"})
    public @ResponseBody String authorization( @ModelAttribute("userInfo") UserInfo argUserInfo, BindingResult result, SessionStatus status) throws Exception
    {
    	if(argUserInfo.getUserInfoCode() == null || argUserInfo.getUserInfoCode() == ""){
    		return "FAIL";
    	}
    	UserInfo user = userInfoService.findByUserName(argUserInfo.getUserInfoCode());
    	if(user == null){
    		return "FAIL";
    	}
    	if(user.getUserInfoName().equals(argUserInfo.getUserInfoName())){
    		return "OK";
    	}
    	return "FAIL";
    }

    @RequestMapping(value = "/jsontest", method = RequestMethod.GET, produces={"application/json"})
    public @ResponseBody UserInfo index(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
        return user;
    }
    
    
    @RequestMapping(value = "/admin", method = RequestMethod.GET)
    public ModelAndView json(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
        ModelAndView mv = new ModelAndView("admin/user/list");
        mv.addObject("user", user);
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.GET)
    public ModelAndView add(ModelMap model) {
        ModelAndView mv = new ModelAndView("admin/user/add");
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.POST)
    public void save(ModelMap model) {

    }
}
